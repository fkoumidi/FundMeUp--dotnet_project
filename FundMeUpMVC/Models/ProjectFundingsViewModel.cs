﻿using FundMeUp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace FundMeUpMVC.Models
{
    public class ProjectFundingsViewModel
    {
        public List<BackerProject> PendingBackerProjects { get; set; }
        public IPagedList<BackerProject> AcceptedBackerProjects { get; set; }
        public ProjectCreator ProjectCreator { get; set; }
        public Project Project { get; set; }
        public float ProjectProgressBar { get; set; }
        public DateTime SearchStartDate { get; set; }
        public DateTime SearchEndDate { get; set; }
        public string FileName { get; set; }
  }
}
