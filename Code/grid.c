#include "sb.h"

point grid_array[MAX_BRICKS];
char *stages[] = {
	&test
};

void set_grid_array () {
	int i;
	int j;
	int y;
	//point temp;
	for (i = 0; i < 10; i++) {
		y = PIXLES_IN_TILE + 4 * i;
		for (j = 0; j < 6; j++) {
			grid_array [i + j].y = y;
			grid_array [i + j].x = PIXLES_IN_TILE + 12 * j;
			//grid_array [i + j] = temp;
		}
	}
}

void set_brick_grid (unsigned char index) {
	char *stage = &(stages[index]);
	int i;
	int j = 0;
	set_grid_array();
	for (i = 0; i < MAX_BRICKS; i++) {
		if (stage[i] != 0) {
		bricks[j].type = stage[i] - 1;
		bricks[j].position.x = grid_array[i].x;
		bricks[j].position.y = grid_array[i].y;
		j++;
		}
	}
}

void display_grid () {
	int i;
	for (i = 0; i < MAX_BRICKS; i++) {
		draw_brick (&(bricks[i]));
	}
}