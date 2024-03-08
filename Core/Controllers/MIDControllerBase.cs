using AutoMapper;
using Core.Repositorio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Core.Controllers
{
    public class MIDControllerBase: ControllerBase
    {
        internal readonly IUnityOfWork _unityOfWork;
        internal readonly IMapper _mapper;
        public MIDControllerBase(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }
    }
}
