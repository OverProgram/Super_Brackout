#include "bricks.h"

int length (bnode *first) {
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
}