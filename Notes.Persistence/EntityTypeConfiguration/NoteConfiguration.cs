﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Notes.Domain;

namespace Notes.Persistence.EntityTypeConfiguration
{
    public class NoteConfiguration : IEntityTypeConfiguration<Note>
    {
        public NoteConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(note => note.ID);
            builder.HasIndex(note => note.ID).IsUnique();
            builder.Property(note => note.Title).HasMaxLength(250);
        }
    }
}
