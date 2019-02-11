﻿using CleanArchitectureTemplate.Application.ToDoItems.Specifications;
using FluentAssertions;
using Xunit;

namespace CleanArchitectureTemplate.UnitTests.Application.ToDoItems.Specifications
{
    public class ToDoItemsByStatusShould
    {
        [Fact]
        public void Construct() =>
            new ToDoItemsByStatus(true)
                .Should().BeOfType<ToDoItemsByStatus>();

        [Fact]
        public void HaveCacheKey() =>
            new ToDoItemsByStatus(true).CacheKey
                .Should().Be("ToDoItemsByStatus-status-True");
    }
}
