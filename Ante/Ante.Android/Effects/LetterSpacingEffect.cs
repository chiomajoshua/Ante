using Android.Widget;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("ante")]
[assembly: ExportEffect(typeof(Ante.Droid.Effects.LetterSpacingEffect), "LetterSpacingEffect")]
namespace Ante.Droid.Effects
{
    public class LetterSpacingEffect : PlatformEffect
    {


        protected override void OnAttached()
        {
            var effect = (Ante.Effects.LetterSpacingEffect)Element.Effects.Where(a => a is Ante.Effects.LetterSpacingEffect).FirstOrDefault();
            if (effect != null)
            {
                var label = Control as TextView;
                label.LetterSpacing = effect.LetterSpace;
            }
        }

        protected override void OnDetached()
        {
            //do nothing
        }
    }
}