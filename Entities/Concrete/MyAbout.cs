using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MyAbout
    {
        [Key]
        public int SkillId { get; set; }

        [StringLength(120)]
        public string MyImage { get; set; }

        [StringLength(100)]
        public string Skill { get; set; }

        public int Range { get; set; }
      
    }
}
