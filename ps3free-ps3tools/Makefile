TOOLS	=	readself pupunpack unself sceverify
TOOLS	+=	makeself norunpack puppack unpkg pkg
TOOLS	+=	cosunpkg cospkg ungpkg
TOOLS	+=	self_rebuilder unspp readself2 scekrit
COMMON	=	tools.o aes.o sha1.o ec.o bn.o mingw_mmap.o
DEPS	=	Makefile tools.h types.h

CC	?=  gcc
CFLAGS	+=  -g -O2 -Wall -W
LDLIBS  =  -lz

# Darwin's MacPorts Default Path
ifeq ($(shell test -e /opt/local/include/gmp.h; echo $$?),0)
CFLAGS  += -I/opt/local/include
LDLIBS  += -L/opt/local/lib
endif
 
OBJS	= $(COMMON) $(addsuffix .o, $(TOOLS))

all: $(TOOLS)

$(TOOLS): %: %.o $(COMMON) $(DEPS)
	$(CC) $(CFLAGS) $(LDFLAGS) -o $@$(SUFFIX) $< $(COMMON) $(LDLIBS)

scekrit: LDLIBS += -lgmp

$(OBJS): %.o: %.c $(DEPS)
	$(CC) $(CFLAGS) -c -o $@ $<

clean:
	-rm -f $(OBJS) $(TOOLS) *.exe
