﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCarService
{
    public class Transaction
    {
        public Guid ID { get; set; }
        public DateTime Date { get; set; }
        public Guid CustomerID { get; set; }
        public Customer Customer { get; set; }
        public Guid CarID { get; set; }
        public Car Car { get; set; }
        public Guid ManagerID { get; set; }
        public Manager Manager { get; set; }
        public decimal TotalPrice { get; set; }
        public List<TransactionLine> Lines { get; set; }


        public Transaction()
        {
            ID = Guid.NewGuid();
            Lines = new List<TransactionLine>();
        }


        public void AddTransactionLine(ServiceTask serviceTask, Engineer engineer, decimal pricePerHr) {
            TransactionLine newLine = new TransactionLine();
            newLine.TransactionID = ID;
            newLine.ServiceTaskID = serviceTask.ID;
            newLine.EngineerID = engineer.ID;
            newLine.Hours = serviceTask.Hours;
            newLine.PricePerHour = pricePerHr;
            newLine.Price = newLine.Hours * newLine.PricePerHour;

            Lines.Add(newLine);
            UpdateTotalPrice();
        }

        public void UpdateTotalPrice() {
            TotalPrice = 0;
            foreach(TransactionLine line in Lines) {
                TotalPrice += line.Price;
            }
        }


    }
}
