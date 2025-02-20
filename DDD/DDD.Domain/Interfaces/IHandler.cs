namespace DDD.Domain.Interfaces;

public interface IHandler<Entity, Get, Post, Put, Patch, Delete> 
    : ICrudCommand<Entity, Get, Post, Put, Patch, Delete>;
