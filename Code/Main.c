#include "sb.h"

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
