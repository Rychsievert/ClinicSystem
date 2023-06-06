using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Application_Tier
{
    // This class manages the commands that are part of the Command Pattern, those being InsertAppointment and DeleteAppointment.
    // Two stacks are created to store the command objects which allows for multiple undo and redo.
    class UndoRedo
    {
        private Stack<Command> undoStack;
        private Stack<Command> redoStack;

        public UndoRedo()
        {
            undoStack = new Stack<Command>();
            redoStack = new Stack<Command>();
        }

        // When a user wishes to undo a command, pop a command object from the stack and call its unexecute method.
        public void Undo()
        {
            if (undoStack.Count != 0)
            {
                Command command = undoStack.Pop();
                command.unexecute();
                redoStack.Push(command); // Push the command to the redo stack so that the original command can be redone by the user. 
            }
        }

        // If the user wishes to redo a command after undoing it, pop a command object from the stack and execute it.
        public void Redo()
        {
            if (redoStack.Count != 0)
            {
                Command command = redoStack.Pop();
                command.execute();
                undoStack.Push(command); // Push the command to the undo stack so that the effect of the command can be undone by the user.
            }
        }

        // Pushes a Command into the undo stack
        public void InsertUndoRedo(Command command)
        {
            undoStack.Push(command);
            redoStack.Clear();
        }

        // Creates an InsertAppointment command for the Appointment passed, and the pushes it into the undo stack
        public void InsertUndoRedoInsert(Appointment appointment)
        {
            Command command = new InsertAppointment(appointment);
            undoStack.Push(command);
            redoStack.Clear();
        }
    }
}
