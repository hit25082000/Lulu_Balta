using Lulu.NotificationContext;
using Lulu.SharedContext;

namespace Lulu.ContentContext
{
     public class CareerItem : Base
    {
        public CareerItem(
            int order,
            string title,
            string description,
            Course course)
        {
            if(course == null)
            {
                AddNotification(new Notification("Course", "Curso Invalido"));
            }
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public Course Course { get; set; }
    }
}