using MediatR;
using MovieManagement.Library.Data;
using MovieManagement.Library.Models;
using MovieManagement.Library.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Library.Handlers
{
    
    public class GetMovieByIdHandler : IRequestHandler<GetMovieByIdQiuery, MovieModel>
    {
        private readonly IMediator _mediator;

        public GetMovieByIdHandler( IMediator mediator)
        {       
            _mediator = mediator;
        }

        public async Task<MovieModel> Handle(GetMovieByIdQiuery request, CancellationToken cancellationToken)
        {
            var movies = await _mediator.Send(new GetMovieListQuery());
            var movie = movies.FirstOrDefault(m=>m.Id==request.id);
            return movie;

        }
    }
}
