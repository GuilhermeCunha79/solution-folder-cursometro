﻿using WebApplication1.Shared;

namespace WebApplication1.Domain.Media;

public class Media : Entity<Identifier>
{
    public MediaIngresso MediaIngresso { get; set; }
    public MediaIngressoDesporto MediaIngressoDesporto { get; set; }
    public MediaSecundario MediaSecundario { get; set; }
    public Utilizador.Utilizador Utilizador { get; set; }
    public Identifier UtilizadorId { get; set; }
    
    public Media()
    {
        
    }

    public Media(string mediaSecundario, string? mediaIngresso, string? mediaIngressoDesporto, string idUtilizador)
    {
        MediaSecundario = new MediaSecundario(mediaSecundario);
        MediaIngresso = new MediaIngresso(mediaIngresso);
        MediaIngressoDesporto = new MediaIngressoDesporto(mediaIngressoDesporto);
        UtilizadorId = new Identifier(idUtilizador);
    }
}