﻿using System;
using System.Collections.Generic;
using System.Text;
using _03BarracksFactory.Contracts;
using P03_BarraksWars.Core.Commands;

namespace P03_BarraksWars.Contracts.Core.Commands
{
	public class ReportCommand : Command
	{
        [Inject]
        private IRepository repository;

        public ReportCommand(string[] data, IRepository repository) : base(data)
		{
            this.repository = repository;
		}

        protected IRepository Repository
        {
            get { return repository; }
            private set { repository = value; }
        }

        public override string Execute()
		{
			string output = this.Repository.Statistics;
			return output;
		}
	}
}
