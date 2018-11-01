#include "sb.h"

/*int length (bnode *first) {
	bnode *currant = first;
	int counter = 0;
	while (currant != 0) {
		counter++;
		currant = currant->next;
	}
	return counter;
}

void set_value_at (bnode *first, int index, brick *dest) {
	bnode *currant = first;
	int i;
	for (i = 0; i < index; i++) {
		currant = currant->next;
	}
	copy_brick(&(currant->value), dest);
}

void copy_brick (brick *source, brick *dest) {
	dest->x = source->x;
	dest->y = source->y;
	dest->index = source->index;
	dest->type = source->type;
	dest->status = source->status;
}*/

void draw_brick (brick *brk) {
	static unsigned int tile_index = 0;
	int i;
	unsigned int currant_tile = brick_starting_tile(brk);
	for (i = 0; i < 4; i++) {
		set_sprite_tile(tile_index, currant_tile);
		move_sprite (tile_index, ((brk->position).x) + (PIXLES_IN_TILE * i), ((brk->position).y));
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
		currant_tile = brick_starting_tile(brk) + TILES_IN_BRICK;
	} else {
		currant_tile = EMPTY_INDEX * TILES_IN_BRICK;
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
	return tile * TILES_IN_BRICK;
}