﻿using api_cinema_challenge.Data;
using api_cinema_challenge.Models;
using api_cinema_challenge.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_cinema_challenge.Controllers
{
    public static class MoviesEndpoint
    {
        public static void ConfigureMoviesEndpoint(this WebApplication app)
        {
            var movieGroup = app.MapGroup("movies");

            movieGroup.MapPost("/{moviesId}", CreateMovie);
            movieGroup.MapGet("/", GetAllMovies);
            movieGroup.MapPut("/{moviesId}", UpdateMovies);
            movieGroup.MapDelete("/{moviesId}", DeleteMovies);
        }        
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> CreateMovie(IMoviesRepository moviesRepository, NewMovie newData)
        {
            //Check that newData has all values
            if(newData.Title == null || newData.Rating == null || newData.Description == null || newData.Runtime == 0)
            {
                return TypedResults.BadRequest("You must enter data for all fields!");
            }
            //Create the new movie
            var movie = new MovieDTO(await moviesRepository.CreateMovie(newData.Title,newData.Rating,newData.Description,newData.Runtime));
            return TypedResults.Created($"/{movie.Id}", movie);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllMovies(IMoviesRepository moviesRepository)
        {
            var movie = MovieDTO.FromRepository(await moviesRepository.GetMovies());
            return TypedResults.Ok(movie);
        }
        [ProducesResponseType(StatusCodes.Status201Created)]
        public static async Task<IResult> UpdateMovies(IMoviesRepository moviesRepository, UpdateMovie newData, int id)
        {
            //Find movie to update via Id
            Movies? movie = await moviesRepository.GetMovie(id);
            //Check if movie exists
            if (movie == null)
            {
                return TypedResults.NotFound($"No movie with id {id} found.");
            }
            //Check that newData has all values
            if (newData.Title == null || newData.Rating == null || newData.Description == null)
            {
                return TypedResults.BadRequest("You must enter data for all fields!");
            }
            //Run the Update method
            movie = await moviesRepository.UpdateMovie(id, newData.Title, newData.Rating, newData.Description, newData.Runtime);
            return TypedResults.Created($"/{movie.Id}", movie);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteMovies(IMoviesRepository moviesRepository, int id)
        {
            //Check that the movie with that id exists
            Movies? movie = await moviesRepository.GetMovie(id);
            if(movie == null)
            {
                return TypedResults.NotFound($"No movie with id {id} found.");
            }
            //Run the Delete method
            movie = await moviesRepository.DeleteMovie(id);
            return TypedResults.Ok(movie);
        }
    }
}