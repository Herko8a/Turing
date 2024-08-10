using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Turing
{
    public delegate void ObjectEventHandler();
    public class TuringMachine
    {
        public event ObjectEventHandler PeriodCompleted;
        public event ObjectEventHandler EndMachine;

        public string SourceCode { get; set; }
        public string Tape { get; set; }
        public int TimeElapsed { get; set; }
        public string CurrentState { get; set; }
        public int CurrentPosition { get; set; }
        public string CurrentValue { get; set; }

        List<Function> Functions;
        Function CurrentFunction;
        bool Continue;

        public void Start()
        {
            CurrentPosition = 0;
            CurrentState = "0";
            CurrentValue = "";
            TimeElapsed = 0;

            // Are there any functions?
            ReadFunctions();
            if (Functions.Count == 0) EndMachine?.Invoke();

            // Loop
            Continue = true;
            while (Continue)
            {
                TimeElapsed++;

                // Read tape
                CurrentValue = Tape.Substring(CurrentPosition, 1);

                // Transition function
                AdvanceToNextFunction();
                if (CurrentFunction == null) return;

                // Execute transition function
                ExecuteFunction();

                Thread.Sleep(50);

            }

        }

        private void ReadFunctions()
        {
            Functions = new List<Function>();

            try
            {
                if (SourceCode.Trim().Length == 0) return;

                // Get lines
                string[] lines = SourceCode.Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < lines.Length; i++)
                {
                    // Remove empty lines
                    string trimmedLine = lines[i].Trim();
                    if (trimmedLine.Length == 0) continue;

                    // Remove comments
                    int commentIndex = trimmedLine.IndexOf(';');
                    if (commentIndex == 0)
                        continue;
                    else if (commentIndex > 0)
                        trimmedLine = trimmedLine.Substring(0, commentIndex).Trim();

                    // Get columns
                    string[] columns = trimmedLine.Split(' ');

                    if (columns.Length == 5)
                    {
                        Function func = new Function()
                        {
                            initialState = columns[0],
                            readValue = columns[1],
                            writeValue = columns[2],
                            moveDirection = columns[3],
                            finalState = columns[4]
                        };

                        Functions.Add(func);
                    }

                }
            }
            catch
            { }

        }

        private void AdvanceToNextFunction()
        {

            CurrentFunction = Functions.FirstOrDefault<Function>(x =>
                                x.initialState.Trim().ToUpper() == CurrentState.Trim().ToUpper() &&
                                (
                                    x.readValue.Trim().ToUpper() == CurrentValue.ToUpper()
                                    ||
                                    (x.readValue.Trim().ToUpper() == "_" && CurrentValue.Trim().Length == 0)
                                    ||
                                    (x.readValue.Trim().ToUpper() == "*" && CurrentValue.Trim().Length != 0)
                                )
                            );
        }

        private void ExecuteFunction()
        {
            string writeValue = CurrentFunction.writeValue.Trim();
            string moveDirection = CurrentFunction.moveDirection.Trim();
            string finalState = CurrentFunction.finalState.Trim();


            // Convert write symbols
            switch (writeValue.Trim())
            {
                case "*":
                    writeValue = CurrentValue;
                    break;
                case "_":
                    writeValue = " ";
                    break;
            }

            // Replace character
            StringBuilder sb = new StringBuilder(Tape);
            sb[CurrentPosition] = Convert.ToChar(writeValue);
            Tape = sb.ToString();

            // Movement
            switch (moveDirection.Trim().ToUpper())
            {
                case "*": // No movement
                    break;
                case "R":  // Right

                    if ((CurrentPosition + 1) >= Tape.Length)
                        Tape = Tape + " ";

                    CurrentPosition++;

                    break;
                case "L":  // Left

                    if ((CurrentPosition - 1) < 0)
                    {
                        Tape = " " + Tape;
                    }
                    else
                        CurrentPosition--;

                    break;
            }

            // Is it finished?
            if (finalState.Trim().ToUpper() == "HALT")
            {
                Continue = false;
                EndMachine?.Invoke();
            }
            else
            {
                Continue = true;
                CurrentState = finalState.Trim();
                PeriodCompleted?.Invoke();
            }

        }

    }

}
