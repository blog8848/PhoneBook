using PhoneBook.Domain.Models;

namespace PhoneBook.Service.Contracts
{
    public interface ICaptchaService
    {
        void CreateQuestion(Captcha captcha);
       // /// <summary>
       // /// Returns captcha object filtered by captchaId.
       // /// </summary>
       // /// <param name="captchaId"></param>
       // /// <returns></returns>
       //// Captcha SelectCaptchaById(int captchaId);

        ///// <summary>
        ///// Gets minimum question id value from captcha table.
        ///// </summary>
        ///// <returns></returns>
        //int GetMinimumQuestionId();

        ///// <summary>
        ///// Gets maximum question id value from captcha table.
        ///// </summary>
        ///// <returns></returns>
        //int GetMaximumQuestionId();

        Captcha GenerateCaptcha();
    }
}