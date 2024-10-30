using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class House
    {

        public House()
        {
            MyProperty = 1;
            
        }
        // public farklı katmanlrda veya projelerden erişim sağlamak için 

        public int Id { get; set; }
        public string Name { get; set; } //properties lerin deafult erişim belirteceleri private dır sadece ilgili class ta geçerli olur demek 
        private int MyProperty { get; set; }// classından başka bir yerde erişilemez

        protected int LastName { get; set; } //bu ise inherit edilen classlarda ve ilgili classlarda tek gelir
    }

   public class HouseTest:House
    {
        public HouseTest()
        {
            LastName=1;
           
        }

        
       
    }

}
