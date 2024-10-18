# The base image for our docker container
FROM    alpine

RUN     apk update &&     \
        apk add curl jq

COPY    . .
RUN     chmod +x ./script.cs

CMD     ["sh","-c","./script.cs"]


