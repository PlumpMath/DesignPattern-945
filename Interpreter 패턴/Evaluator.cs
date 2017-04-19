using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_패턴
{
    class Evaluator : Expression
    {
        private Stack<Expression> contents;

        public Evaluator(string expression)
        {
            Stack<Expression> expressionStack = new Stack<Expression>();
            foreach (string e in expression.Split(' '))
            {
                switch (e)
                {
                    case "a":
                        // 커피 선택
                        Coffee coffeeExpression = new Coffee(e);
                        expressionStack.Push(coffeeExpression);
                        break;
                    case "-t":
                        // 샷추가
                        Shot shotExpression = new Shot();
                        expressionStack.Push(shotExpression);
                        break;
                    case "-s":
                        // 시럽추가
                        Syrup syrupExpression = new Syrup();
                        expressionStack.Push(syrupExpression);
                        break;
                    case "-w":
                        // 휘핑크림
                        WhippingCream wcExpression = new WhippingCream();
                        expressionStack.Push(wcExpression);
                        break;
                    default:
                        break;

                }
            }
            contents = expressionStack;
        }

        public string interpret()
        {
            string result = "";
            foreach (var c in contents)
            {
                result += c.interpret();
            }
            return result;
        }
    }
}
