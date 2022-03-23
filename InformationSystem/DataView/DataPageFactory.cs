﻿using InformationSystem.Controllers;
using InformationSystem.Models;
using InformationSystem.Services;
using InformationSystem.Services.Factories;

namespace InformationSystem.DataView
{
    public class DataPageFactory : IPageFactory<IDataController, UserControl>
    {
        public IPage<IDataController, UserControl> CreatePage()
        {
            TableService tableService = new TableService();
            DataView dataView = new DataView();
            DataController dataController = new DataController(dataView, tableService, MessageService.Instance);
            return new Page<IDataController, UserControl>(dataView, dataController, "Data View");
        }
    }
}
