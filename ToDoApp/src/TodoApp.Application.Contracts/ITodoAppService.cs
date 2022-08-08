using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace TodoApp
{
    public interface ITodoAppService : IApplicationService
    {
        Task<List<TodoItemDto>> GetListAsync();

        Task<TodoItemDto> CreateAsync(string text);

        Task DeleteAsync(Guid id);
    }

   
}
public class TodoItemDto
{
    public Guid Id { get; set; }

    public string Text { get; set; }
}


