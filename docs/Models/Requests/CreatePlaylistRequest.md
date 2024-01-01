# CreatePlaylistRequest


## Fields

| Field                                   | Type                                    | Required                                | Description                             |
| --------------------------------------- | --------------------------------------- | --------------------------------------- | --------------------------------------- |
| `Title`                                 | *string*                                | :heavy_check_mark:                      | name of the playlist                    |
| `Type`                                  | [Type](../../Models/Requests/Type.md)   | :heavy_check_mark:                      | type of playlist to create              |
| `Smart`                                 | [Smart](../../Models/Requests/Smart.md) | :heavy_check_mark:                      | whether the playlist is smart or not    |
| `Uri`                                   | *string*                                | :heavy_minus_sign:                      | the content URI for the playlist        |
| `PlayQueueID`                           | *double*                                | :heavy_minus_sign:                      | the play queue to copy to a playlist    |