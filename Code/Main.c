#include "sb.h"

void draw_brick (brick *brick);
void break_brick (brick *brk);
void update_brick (brick *brk);
int brick_starting_tile (brick *brk);

const unsigned char tiles_in_brick = 8;
const unsigned char pixles_in_tile = 8;
brick bricks[MAX_BRICKS];

void main () {
	brick brk;
	set_sprite_data(0, 111, sprites);
	brk.x = 75;
	brk.y = 75;
	brk.type = 1;
	SPRITES_8x16;
	draw_brick(&brk);
	SHOW_SPRITES;
	delay (1000);
	break_brick(&brk);
	update_brick(&brk);
}

void draw_brick (brick *brk) {
	static unsigned int tile_index = 0;
	int i;
	unsigned int currant_tile = brick_starting_tile(brk);
	for (i = 0; i < 4; i++) {
		set_sprite_tile(tile_index, currant_tile);
		move_sprite (tile_index, (brk->x) + (pixles_in_tile * i), (brk->y));
		tile_index++;
		currant_tile += 2;
	}
	brk->status = 0;
}

void break_brick (brick *brk) {
	brk->status++;
}

void update_brick (brick *brk) {
	int i;
	int currant_tile;
	int currant_tile_index;
	if (brk->status <= brk->type) {
		currant_tile = brick_starting_tile(brk) + tiles_in_brick;
	} else {
		currant_tile = EMPTY_INDEX * tiles_in_brick;
	}
	currant_tile_index = brk->index;
	for (i = 0; i < 4; i++) {
		set_sprite_tile(currant_tile_index, currant_tile);
		currant_tile += 2;
		currant_tile_index++;
	}
}

int brick_starting_tile (brick *brk) {
	int tile = 0;
	int i;
	for (i = 0; i <= brk->type; i++) {
		tile += i;
	}
	return tile * tiles_in_brick;
}