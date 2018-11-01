#include <gb/gb.h>
#include <stdlib.h>
#include "Sprites2.h"
#include "stages.h"
#include "bricks.h"
#include "grid.h"

#define MAX_BRICKS 60
#define EMPTY_INDEX 10
#define TILES_IN_BRICK 8
#define PIXLES_IN_TILE 8

#ifndef MAIN
extern brick bricks[MAX_BRICKS];
#else
brick bricks[MAX_BRICKS];
#endif