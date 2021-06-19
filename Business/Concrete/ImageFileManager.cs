using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ImageFileManager : IImageService
    {
        IImageFileDal _imagefileDal;

        public ImageFileManager(IImageFileDal imagefileDal)
        {
            _imagefileDal = imagefileDal;
        }

        public List<ImageFile> GetList()
        {
           return _imagefileDal.List();
        }
    }
}
