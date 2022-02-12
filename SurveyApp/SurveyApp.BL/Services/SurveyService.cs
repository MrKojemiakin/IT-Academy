using SurveyApp.Interfaces.BL;
using SurveyApp.Interfaces.Data;
using SurveyApp.Models.DTO;
using SurveyApp.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;


namespace SurveyApp.BL.Services
{
    public class SurveyService : ISurveyService
    {
        private readonly IGenericRepository genericRepository;

        public SurveyService(IGenericRepository genericRepository)
        {
            this.genericRepository = genericRepository;
        }
        public int AddSurvey(CreateSurveyDTO dto)
        {
            var survey = new Survey()
            {
                Name = dto.Name,
            };
            genericRepository.Create(survey);
            return survey.Id;
        }

    }


}
