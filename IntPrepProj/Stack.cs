using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IntPrepProj
{
    public partial class Stack : Form
    {
        Linkedlist<int> head = null;
        public Stack()
        {
            InitializeComponent();
        }

        private void GetMinInStack_Click(object sender, EventArgs e)
        {
            MinMaxStack stack = new MinMaxStack();
            stack.Push(3);
            stack.Push(5);
            stack.Push(7);
            stack.Push(9);
            stack.Push(8);
            stack.Push(2);
            stack.Push(4);
            stack.Push(6);
            stack.Push(1);
            stack.Push(2);

            stack.Print();
        }

        private void StackInLinkedList_Click(object sender, EventArgs e)
        {
            Push(1);
            Push(2);
            Push(3);
            Push(4);
            Pop();
            Pop();
            Push(5);
            Push(6);
            Pop();
            Pop();
            var res = head;
        }

        public void Push(int val)
        {
            Linkedlist<int> node = null;
            if (head == null)
            {
                head = new Linkedlist<int>();
                node = head;
                head.data = val;
            }
            else
            {
                node = new Linkedlist<int>();
                node.data = val;
                node.next = head;
                head = node;
            }
        }

        public int Pop()
        {
            if (head == null)
                throw new Exception("Stack is empty");

            var node = head;
            head = head.next;
            return node.data;
        }

        private void StackUsingQueueFastOnPush_Click(object sender, EventArgs e)
        {
            StackUsingQueue_Push stack1 = new StackUsingQueue_Push();
            stack1.Push(3);
            stack1.Push(5);
            stack1.Push(9);
            var x = stack1.Pop();
            stack1.Push(10);
            stack1.Push(16);
            var x1 = stack1.Pop();
            x1 = stack1.Pop();
            x1 = stack1.Pop();
            x1 = stack1.Pop();
            x1 = stack1.Pop();
        }

        private void StackUsingQueue_FastOnPop_Click(object sender, EventArgs e)
        {
            StackUsingQueue_Pop stack1 = new StackUsingQueue_Pop();
            stack1.Push(3);
            stack1.Push(5);
            stack1.Push(9);
            var x = stack1.Pop();
            stack1.Push(10);
            stack1.Push(16);
            var x1 = stack1.Pop();
            x1 = stack1.Pop();
            x1 = stack1.Pop();
            x1 = stack1.Pop();
            x1 = stack1.Pop();
        }

        private void ExpressionEvaluation_Click(object sender, EventArgs e)
        {
            Console.WriteLine(Evaluate("10 + 2 * 6"));
            Console.WriteLine(Evaluate("100 * 2 + 12"));
            Console.WriteLine(Evaluate("100 * ( 2 + 12 )"));
            Console.WriteLine(Evaluate("100 * ( 2 + 12 ) / 14"));
        }

        public static int Evaluate(string expression)
        {
            char[] tokens = expression.ToCharArray();

            // Stack for numbers: 'values'  
            Stack<int> values = new Stack<int>();

            // Stack for Operators: 'ops'  
            Stack<char> ops = new Stack<char>();

            for (int i = 0; i < tokens.Length; i++)
            {
                // Current token is a whitespace, skip it  
                if (tokens[i] == ' ')
                {
                    continue;
                }

                // Current token is a number, push it to stack for numbers  
                if (tokens[i] >= '0' && tokens[i] <= '9')
                {
                    StringBuilder sbuf = new StringBuilder();
                    // There may be more than one digits in number  
                    while (i < tokens.Length && tokens[i] >= '0' && tokens[i] <= '9')
                    {
                        sbuf.Append(tokens[i++]);
                    }
                    values.Push(int.Parse(sbuf.ToString()));
                }

                // Current token is an opening brace, push it to 'ops'  
                else if (tokens[i] == '(')
                {
                    ops.Push(tokens[i]);
                }

                // Closing brace encountered, solve entire brace  
                else if (tokens[i] == ')')
                {
                    while (ops.Peek() != '(')
                    {
                        values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
                    }
                    ops.Pop();
                }

                // Current token is an operator.  
                else if (tokens[i] == '+' || tokens[i] == '-' || tokens[i] == '*' || tokens[i] == '/')
                {
                    // While top of 'ops' has same or greater precedence to current  
                    // token, which is an operator. Apply operator on top of 'ops'  
                    // to top two elements in values stack  
                    while (ops.Count > 0 && hasPrecedence(tokens[i], ops.Peek()))
                    {
                        values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
                    }

                    // Push current token to 'ops'.  
                    ops.Push(tokens[i]);
                }
            }

            // Entire expression has been parsed at this point, apply remaining  
            // ops to remaining values  
            while (ops.Count > 0)
            {
                values.Push(applyOp(ops.Pop(), values.Pop(), values.Pop()));
            }

            // Top of 'values' contains result, return it  
            return values.Pop();
        }

        // Returns true if 'op2' has higher or same precedence as 'op1',  
        // otherwise returns false.  
        public static bool hasPrecedence(char op1, char op2)
        {
            if (op2 == '(' || op2 == ')')
            {
                return false;
            }
            if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        // A utility method to apply an operator 'op' on operands 'a'   
        // and 'b'. Return the result.  
        public static int applyOp(char op, int b, int a)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b == 0)
                    {
                        throw new System.NotSupportedException("Cannot divide by zero");
                    }
                    return a / b;
            }
            return 0;
        }
    }

    #region MinMax Stack
    public class MinMaxVal
    {
        public int min;
        public int max;
        public int val;
    }

    public partial class MinMaxStack : IMinMaxStack
    {
        List<MinMaxVal> stackList = new List<MinMaxVal>();
        int currentIndex = -1;
    
        public int GetMax()
        {
            if (currentIndex < 0)
            {
                throw new Exception("Stack is empty");
            }
            return stackList[currentIndex].max;
        }

        public int GetMin()
        {
            if (currentIndex < 0)
            {
                throw new Exception("Stack is empty");
            }
            return stackList[currentIndex].min;
        }

        public int Peek()
        {
            if (currentIndex < 0)
            {
                throw new Exception("Stack is empty");
            }
            return stackList[currentIndex].val;
        }

        public int Pop()
        {
            if(currentIndex < 0)
            {
                throw new Exception("Stack is empty");
            }
            var retValue = stackList[currentIndex];
            stackList.RemoveAt(currentIndex);
            currentIndex--;
            return retValue.val;
        }

        public void Push(int element)
        {
            MinMaxVal minMaxVal = new MinMaxVal();
            if(stackList.Count() <= 0)
            {
                minMaxVal.val = element;
                minMaxVal.min = element;
                minMaxVal.max = element;
            }
            else
            {
                minMaxVal.min = Math.Min(GetMin(), element);
                minMaxVal.max = Math.Max(GetMax(), element);
                minMaxVal.val = element;
            }
            stackList.Add(minMaxVal);
            currentIndex++;
        }

        public void Print()
        {
            foreach(var item in stackList)
            {
                Console.WriteLine($"Value is {item.val} -- Minimum Value is {item.min} -- Maximum Value is {item.max}");
            }
        }
    }

    public interface IMinMaxStack
    {
        int GetMin();
        int GetMax();
        int Pop();
        int Peek();
        void Push(int element);
        void Print();
    }

    #endregion

    #region LinkedList
    public class Linkedlist<T>
    {
        public T data;
        public Linkedlist<T> next;
    }

    #endregion

    #region Stack Using Queue - Fast on Push

    public class StackUsingQueue_Push
    {
        private Queue<int> queue1 = new Queue<int>();
        private Queue<int> queue2 = new Queue<int>();

        public void Push(int val)
        {
            queue1.Enqueue(val);
        }

        public int Pop()
        {
            if(queue1.Count <= 0)
            {
                throw new InvalidOperationException("No elements to Pop");
            }

            int retValue = -1;
            while(queue1.Count > 0)
            {
                var curr = queue1.Dequeue();
                if(queue1.Count != 0)
                {
                    queue2.Enqueue(curr);
                }
                else
                {
                    retValue = curr;
                }
            }

            while(queue2.Count > 0)
            {
                queue1.Enqueue(queue2.Dequeue());
            }

            return retValue;
        }
    }

    #endregion

    #region Stack Using Queue - Fast on Pop

    public class StackUsingQueue_Pop
    {
        private Queue<int> queue1 = new Queue<int>();
        private Queue<int> queue2 = new Queue<int>();

        public void Push(int val)
        {
            if(queue1.Count <= 0)
            {
                queue1.Enqueue(val);
            }
            else
            {
                queue2.Enqueue(val);
                while(queue1.Count > 0)
                {
                    queue2.Enqueue(queue1.Dequeue());
                }
                Queue<int> temp = queue2;
                queue2 = queue1;
                queue1 = temp;
            }
        }

        public int Pop()
        {
            if(queue1.Count <= 0)
                throw new InvalidOperationException("No elements to Pop");

            return queue1.Dequeue();
        }
    }

    #endregion
}
