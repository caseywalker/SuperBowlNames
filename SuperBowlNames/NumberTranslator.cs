using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBowlNames
{
  public class NumberTranslator
  {
    public string Translate(int numberToTranslate)
    {
      //switch expression
      return numberToTranslate switch
      {
        1 => "I",
        3 => "III",
        4 => "IV",
        _ => ""
      };


      //switch (numberToTranslate)
      //{
      //  case 1:
      //    return "I";
      //  case 3:
      //    return "III";
      //  case 4:
      //    return "IV";
      //  default:
      //    return "";
      //}

    }
  }
}
