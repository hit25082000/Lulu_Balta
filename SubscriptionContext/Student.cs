using Lulu.SharedContext;
using Lulu.NotificationContext;

namespace Lulu.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public User User { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public void CreateSubscription(Subscription subscription)
        {
            if(IsPremiun)
            {
                AddNotification(new Notification("Premium", "O aluno ja tem uma assinatura ativa"));
                return;
            }
            Subscriptions.Add(subscription);
        }
        public bool IsPremiun => Subscriptions.Any(x=> !x.IsInactive);
    }
}