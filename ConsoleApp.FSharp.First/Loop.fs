module Loop

for i = 1 to 20 do
    printfn "Line %d" i

for i = 20 downto 1 do
    printfn "%d" i

let list = [234;53;137;43;77;]
for i in list do
    printfn "%d" i

let sqe1 = seq {for i in 1 .. 10 ->(i,i*i)}
for (a,seqr) in sqe1 do
    printfn "%d squared is %d" a seqr
