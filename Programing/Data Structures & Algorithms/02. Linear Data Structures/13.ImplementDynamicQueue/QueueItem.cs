using System;
using System.Linq;

namespace _13.ImplementDynamicQueue
{
    class QueueItem<T>
    {
        T value;
        QueueItem<T> previousItem;

        public QueueItem()
        {
        }

        public QueueItem(T value)
        {
            this.Value = value;
        }

        public T Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        public QueueItem<T> PreviousItem
        {
            get
            {
                return this.previousItem;
            }
            set
            {
                this.previousItem = value;
            }
        }
    }
}