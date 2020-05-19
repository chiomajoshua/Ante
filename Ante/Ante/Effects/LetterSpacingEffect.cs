using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Ante.Effects
{
    public class LetterSpacingEffect : RoutingEffect
    {
        public LetterSpacingEffect() : base("ante.LetterSpacingEffect")
        {

        }

        public float LetterSpace
        {
            get;
            set;
        }
    }
}