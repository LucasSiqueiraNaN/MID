using AutoMapper;
using Core.Dominio;
using Core.DTOs;
using Core.Repositorio.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Core.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PessoasController : MIDControllerBase
    {

        public PessoasController(IUnityOfWork unityOfWork, IMapper mapper) : base(unityOfWork, mapper) { }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PessoaDTO>>> GetObterPessoas()
        {
            var pessoas = await _unityOfWork.PessoaRepositorio.Get().ToListAsync();
            if (pessoas == null || pessoas.Count == 0)
            {
                return NotFound("Não existem pessoas cadastradas");
            }
            var pessoasDto = _mapper.Map<IEnumerable<Pessoa>>(pessoas);
            return Ok(pessoasDto);
        }


        [HttpPost]
        public async Task<ActionResult> PostInserirPessoa(PessoaDTO pessoaDto)
        {
            var pessoa = _mapper.Map<Pessoa>(pessoaDto);
            if (pessoa is null)
            {
                return BadRequest("Não foi possível realizar o cadastro");
            }

            if (!await _unityOfWork.PessoaRepositorio.AdicionarPessoaSeNaoExistir(pessoa))
            {
                return Conflict("Pessoa já cadastrada");
            }
            await _unityOfWork.Commit();

            var pessoaDTO = _mapper.Map<PessoaDTO>(pessoa);
            return Ok(pessoaDTO);

        }
    }
}
