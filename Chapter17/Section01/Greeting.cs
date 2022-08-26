namespace Section01 {
    class GreetingMorning : IGreeting {
        public string GetMessage() {
            return "おはよう";
        }
    }

    class GreetingAfternoon : IGreeting {
        public string GetMessage() {
            return "こんにちは";
        }
    }

    class GreetingEvening : IGreeting {
        public string GetMessage() {
            return "こんばんは";
        }
    }

}
