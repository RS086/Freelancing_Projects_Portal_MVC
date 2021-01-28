﻿namespace Freelancing_Projects_Portal_MVC.Models
{
    //Bid information
    public class Bid
    {
        //Bid id 
        public int Id { get; set; }

        //Bid value 
        public decimal BidValue { get; set; }


        // Project id related key
        public int ProjectId { get; set; }

        //Developer related key
        public int DeveloperId { get; set; }

        //Project reference
        public Project Project { get; set; }

        //Developer reference
        public Developer Developer { get; set; }




    }
}
