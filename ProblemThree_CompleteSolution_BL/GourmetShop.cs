using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemThree_CompleteSolution_BL
{
    public abstract class GourmetShop
    {
        public int ItemCode { get; set; }
        public string ItemName { get; set; }
        protected Dictionary<int, double> ItemPrice { get; set; }
        public abstract double PayPerPiece(int quantity);
        public abstract double PayPerWeight(int weight);
        public GourmetShop(int iCode, string iName)
        {
            ItemCode = iCode;
            ItemName = iName;
        }
    }
}
