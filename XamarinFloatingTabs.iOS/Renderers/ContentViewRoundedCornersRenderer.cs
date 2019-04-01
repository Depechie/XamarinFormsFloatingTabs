using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinFloatingTabs.Controls;
using XamarinFloatingTabs.iOS.Renderers;

[assembly: ExportRenderer(typeof(ContentViewRoundedCorners), typeof(ContentViewRoundedCornersRenderer))]
namespace XamarinFloatingTabs.iOS.Renderers
{
    public class ContentViewRoundedCornersRenderer : VisualElementRenderer<ContentView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ContentView> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
                return;

            Layer.CornerRadius = ((ContentViewRoundedCorners)Element).CornerRadius;
            ClipsToBounds = true;

            UpdateBorder();
        }

        private ContentViewRoundedCorners FormsControl
        {
            get { return Element as ContentViewRoundedCorners; }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == ContentViewRoundedCorners.CornerRadiusProperty.PropertyName)
                this.Layer.CornerRadius = (float)FormsControl.CornerRadius;

            if (e.PropertyName == ContentViewRoundedCorners.BorderColorProperty.PropertyName)
                UpdateBorder();

            if (e.PropertyName == ContentViewRoundedCorners.BorderThicknessProperty.PropertyName)
                UpdateBorder();
        }

        private void UpdateBorder()
        {
            this.Layer.BorderColor = FormsControl.BorderColor.ToCGColor();
            this.Layer.BorderWidth = FormsControl.BorderThickness;
        }
    }
}