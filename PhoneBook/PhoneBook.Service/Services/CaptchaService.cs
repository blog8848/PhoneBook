using System;
using PhoneBook.Data.Infrastructures;
using PhoneBook.Domain.Models;
using PhoneBook.Service.Contracts;

namespace PhoneBook.Service.Services
{
    public class CaptchaService : ICaptchaService
    {
        private readonly IUnitOfWork _unitOfWork;
        public CaptchaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void CreateQuestion(Captcha captcha)
        {
            _unitOfWork.CaptchaRepository.Insert(captcha);
            _unitOfWork.Commit();
        }
        //public Captcha SelectCaptchaById(int captchaId)
        //{
        //    return _unitOfWork.CaptchaRepository.Single(captchaId);
        //}

        //public int GetMinimumQuestionId()
        //{
        //    return _unitOfWork.CaptchaRepository.MinCaptchaId();
        //}

        //public int GetMaximumQuestionId()
        //{
        //    return _unitOfWork.CaptchaRepository.MaxCaptchaId();
        //}

        public Captcha GenerateCaptcha()
        {
            Random randomCaptchaId = new Random();
            int captchaId = randomCaptchaId.Next(_unitOfWork.CaptchaRepository.MinCaptchaId(), _unitOfWork.CaptchaRepository.MaxCaptchaId() + 1);
            return _unitOfWork.CaptchaRepository.Single(captchaId);
        }
    }
}
