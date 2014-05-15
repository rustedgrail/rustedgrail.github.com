window.CS = ->
  createBoard = ->
    [
      [0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
      [0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
      [0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
      [0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
      [0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
      [0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
      [0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
      [0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
      [0, 0, 0, 0, 0, 0, 0, 0, 0, 0],
      [0, 0, 0, 0, 0, 0, 0, 0, 0, 0]
    ]

  getNeighbors = (board, x, y) ->
    sum = 0
    for modX in [-1..1]
      for modY in [-1..1]
        if 0 <= x + modX < 10 and 0 <= y + modY < 10 and
        x !=0 or y != 0
          sum += board[x + modX][y + modY]
    sum

  shouldLive = (board, x, y) ->
    neighbors = getNeighbors board, x, y
    neighbors == 3 or (neighbors == 2 && board[x][y])

  nextStep = (board) ->
    nextBoard = createBoard()
    for row, x in board
      for cell, y in row
        nextBoard[x][y] = if shouldLive(board, x, y) then 1 else 0
    nextBoard

  {createBoard, getNeighbors, shouldLive, nextStep}
