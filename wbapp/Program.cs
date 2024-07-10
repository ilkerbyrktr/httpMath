var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

int firstNumber = 0,secondNumber = 0, result= 0;

app.Run(async (HttpContext context) =>
{
    if (context.Request.Method == "GET")
    {
        if (context.Request.Query.ContainsKey("firstNumber"))
        {
            firstNumber = Convert.ToInt32(context.Request.Query["firstNumber"]);
            await context.Response.WriteAsync($"<p> first num is : {firstNumber}</p>");
        }

        if (context.Request.Query.ContainsKey("secondNumber"))
        {
            secondNumber = Convert.ToInt32(context.Request.Query["secondNumber"]);
            await context.Response.WriteAsync($"<p> second num is : {secondNumber}</p>");
        }

        if (context.Request.Query.ContainsKey("operation"))
        {
            string operation = context.Request.Query["operation"];
            switch (operation)
            {
                case "add":
                    result = firstNumber + secondNumber;
                    await context.Response.WriteAsync($"<p>The result is {result}</p>");
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    await context.Response.WriteAsync($"<p>The result is {result}</p>");
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    await context.Response.WriteAsync($"<p>The result is {result}</p>");
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    await context.Response.WriteAsync($"<p>The result is {result}</p>");
                    break;
                case "%":
                    result = firstNumber % secondNumber;
                    await context.Response.WriteAsync($"<p>The result is {result}</p>");
                    break;
                default:
                    await context.Response.WriteAsync($"<p>You entered a wrong operation!!!</p>");
                    break;

            }

        }
    }

});

app.Run();
