﻿using System;

namespace Oceans.Exercise
{
    public class Subscription
    {
        /// <summary>
        /// The name of the subscribed service
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The month the subscription expires
        /// </summary>
        internal int ExpirationMonth { get; }

        /// <summary>
        /// The year the subscription expires
        /// </summary>
        internal int ExpirationYear { get; }

        public bool IsExpired()
        {
            var expirationDate = new DateTime(this.ExpirationYear, this.ExpirationMonth, DateTime.DaysInMonth(this.ExpirationYear, this.ExpirationMonth));
            return DateTime.Now > expirationDate;
        }

        /// <summary>
        /// Creates a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        /// <param name="expirationMonth">The month the subscription expires</param>
        /// <param name="expirationYear">The year the subscription expires</param>
        public Subscription(int expirationMonth, int expirationYear)
        {
            this.ExpirationMonth = expirationMonth;
            this.ExpirationYear = expirationYear;
        }
    }
}