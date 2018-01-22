public enum Terreno{
    Tierra = 0,
    Agua = 1,
    Calle = 0
}

public static class Mapas{
    public static Terreno[][] Lago{
        get{
            Terreno O = Terreno.Tierra;
            Terreno I = Terreno.Calle;
            Terreno _ = Terreno.Agua;
            return new Terreno[][]{
                new Terreno[]{ O, O, O, O, O, O, O, O, O, O },
                new Terreno[]{ O, O, I, I, I, I, I, I, O, O },
                new Terreno[]{ O, O, I, _, _, _, _, I, O, O },
                new Terreno[]{ O, O, I, _, _, _, _, I, O, O },
                new Terreno[]{ O, O, I, _, _, _, _, I, I, O },
                new Terreno[]{ O, O, I, I, I, _, _, _, I, O },
                new Terreno[]{ O, O, O, O, I, _, _, _, I, O },
                new Terreno[]{ O, O, O, O, I, _, _, I, I, O },
                new Terreno[]{ O, O, O, O, I, I, I, I, O, O },
                new Terreno[]{ O, O, O, O, O, O, O, O, O, O }
            };
        }
    }
}