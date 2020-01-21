﻿using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using TipCalc.Core.ViewModels;
using UIKit;

namespace TipCalc.iOS.Views
{
    public partial class TipView : MvxViewController
    {
        public TipView() : base("TipView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            this.CreateBinding(TipLabel).To((TipViewModel vm) => vm.Tip).Apply();
            this.CreateBinding(SubTotalTextField).To((TipViewModel vm) => vm.SubTotal).Apply();
            this.CreateBinding(GenerositySlider).To((TipViewModel vm) => vm.Generosity).Apply();

            View.AddGestureRecognizer(new UITapGestureRecognizer(() =>
            {
                this.SubTotalTextField.ResignFirstResponder();
            }));
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

