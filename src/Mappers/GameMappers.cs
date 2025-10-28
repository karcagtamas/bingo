using Bingo.Models.Games;

namespace Bingo.Mappers;

public static class GameMappers
{
    public static GameMatrixCell ToMatrixCell(this GameCellDataModel model)
    {
        return new GameMatrixCell(model.OrderNo, model.Caption);
    }

    public static GameMatrixCell ToMatrixCell(this GameCellEditModel model)
    {
        return new GameMatrixCell(model.OrderNo, model.Caption);
    }
}