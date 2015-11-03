cmake_minimum_required( VERSION 2.8 )

PROJECT(XLive)

set(CMAKE_BUILD_TYPE Release)

# C++11
#set (CMAKE_CXX_FLAGS "-std=c++11")

set(CMAKE_INCLUDE_CURRENT_DIR ON)

SET(SRCS
  main.cpp
  safewrite.cpp
  codepatches.cpp
  d3dx.cpp
  xlive.cpp
)

# Headers
SET(HDRS
  safewrite.h
  codepatches.h
  d3dx.h
  xlive.h
)

add_library(xlive SHARED ${SRCS} ${HDRS})