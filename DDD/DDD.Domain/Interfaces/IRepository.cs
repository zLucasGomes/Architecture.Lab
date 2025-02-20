namespace DDD.Domain.Interfaces;

public interface IRepository<Entity, Get, Post, Put, Patch, Delete>
    : ICrudCommand<Entity, Get, Post, Put, Patch, Delete>;

