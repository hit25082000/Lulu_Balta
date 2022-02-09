using Lulu.ContentContext;
using Lulu.SubscriptionContext;
     
var articles = new List<Article>();
articles.Add(new Article("Artigo sobre Operação", "Orientação"));
articles.Add(new Article("Artigo sobre C#", "C#"));
articles.Add(new Article("Artigo sobre .net", ".net"));

// foreach(var article in articles)
// {
//     Console.WriteLine(article.Id);
//     Console.WriteLine(article.Title);
//     Console.WriteLine(article.Url);
// }

var courses = new List<Course>();

var courseOop = new Course("Fundamento OOP", "OOP");
var courseCsharp = new Course("Fundamento C#", "C#");
var courseAspNet = new Course("Fundamento Asp.net", "Asp.net");

courses.Add(courseOop);
courses.Add(courseCsharp);
courses.Add(courseAspNet);

var careers = new List<Career>();
var careerDot = new Career("Especialista .NET",".Net especial"); 
var careerItem2 = new CareerItem(2, "Aprenda .Net aqui", "", courseAspNet);
var careerItem3 = new CareerItem(3, "Aprenda OOP aqui", "", courseOop);
var careerItem = new CareerItem(1, "Comece por aqui", "", null);
careerDot.Items.Add(careerItem2);
careerDot.Items.Add(careerItem3);
careerDot.Items.Add(careerItem);
careers.Add(careerDot);

foreach(var career in careers)
{
    Console.WriteLine(career.Title);
    foreach(var item in career.Items.OrderBy(x=>x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Course?.Title);
        Console.WriteLine(item.Course?.Level);

        foreach(var notification in item.Notifications)
            Console.WriteLine($"{notification.Property} - {notification.Message}");
    }
}

var paypalSubscription = new PaypalSubscription();
var student = new Student();

student.CreateSubscription(paypalSubscription);


