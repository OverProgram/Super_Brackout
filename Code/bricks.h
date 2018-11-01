typedef struct _point point;
struct _point {
	unsigned char x, y;
};

typedef struct _brick brick;
struct _brick {
	unsigned char type, status, index;
	point position;
};

/*typedef struct _bnode bnode;
struct _bnode {
	brick value;
	bnode *next;
};

int length (bnode *first);

void set_value_at (bnode *first, int index, brick *return_address);

void copy_brick (brick *source, brick *dest);*/

void draw_brick (brick *brick);

void break_brick (brick *brk);

void update_brick (brick *brk);

int brick_starting_tile (brick *brk);