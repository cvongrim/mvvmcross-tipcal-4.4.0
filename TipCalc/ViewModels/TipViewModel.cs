﻿using MvvmCross.Core.ViewModels;
using TipCalc.Core.Services;

namespace TipCalc.Core.ViewModels
{
    public class TipViewModel : MvxViewModel
    {
        readonly ICalculationSerivce _calculationService;

        public TipViewModel(ICalculationSerivce calculationService)
        {
            _calculationService = calculationService;
        }

        public override void Start()
        {
            _subTotal = 100;
            _generosity = 10;
            Recalcuate();
            base.Start();
        }

        double _subTotal;

        public double SubTotal
        {
            get { return _subTotal; }
            set
            {
                _subTotal = value;
                RaisePropertyChanged(() => SubTotal);
                Recalcuate();
            }
        }

        int _generosity;

        public int Generosity
        {
            get { return _generosity; }
            set
            {
                _generosity = value;
                RaisePropertyChanged(() => Generosity);
                Recalcuate();
            }
        }

        double _tip;

        public double Tip
        {
            get { return _tip; }
            set
            {
                _tip = value;
                RaisePropertyChanged(() => Tip);
            }
        }

        void Recalcuate()
        {
            Tip = _calculationService.TipAmount(SubTotal, Generosity);
        }
    }
}
