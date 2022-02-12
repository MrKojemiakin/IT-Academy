using SurveyApp.Models.DTO;

namespace SurveyApp.Interfaces.BL
{
    public interface ISurveyService
    {
        int AddSurvey(CreateSurveyDTO dto);
        void DeleteSurvey(int id);

        void EditSurvey(EditSurveyDTO dto);
        void AddQuestion(CreateQuestionDTO dto);

        void EditQuestion(EditQuestion dto);


    }
}