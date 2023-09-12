using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //Çıplak class kalmasın standardı (bir class yanına interface ya da inheritance almıyorsa ileride problem yaşayacağız demektir.)
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
