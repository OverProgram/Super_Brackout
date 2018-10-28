typedef struct _brick brick;
struct _brick {
	unsigned char x, y, type, status, index;
};

typedef struct _bnode bnode;
struct _bnode {
	brick value;
	bnode *next;
};

int length (bnode *first);

void set_value_at (bnode *first, int index, brick *return_address);

void copy_brick (brick *source, brick *dest);