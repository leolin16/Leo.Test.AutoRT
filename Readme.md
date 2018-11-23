
query getScreensInfo($screenName: String!) {
  screen (screenName: $screenName) {
    category
    screenName
    screenJpName
  }
  screens {
    category
    screenName
    screenJpName
  }
}


query getScreens{
  screens {
    id
    category
    screenName
    screenJpName
  }
}

mutation createScreen{
  createScreen(screen: {category: "テスト", screenName: "LeoLin", screenJpName: "林佳偉"}) {
    category
    screenName
    screenJpName
  }
}

----
{
  "screenName": "EC_CHANGE_ACTOR_MF"
}