import java.util.Arrays;

public class Test {

    public static void main(String[] args) {
        String[] cardcase = {"클로버", "하트", "다이아", "스페이드"};
        String[] cardnumber = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        // 족보 배열

        // 플레이어 카드 생성
        System.out.println("플레이어의 카드");
        String[] playerCards = generateCards(cardcase, cardnumber, 5);
        printCards(playerCards);

        // 컴퓨터 카드 생성
        System.out.println(" ");
        System.out.println("컴퓨터의 카드");
        String[] computerCards = generateCards(cardcase, cardnumber, 5);
        printCards(computerCards);

        // 족보 확인
        System.out.println(" ");
        System.out.println("플레이어의 족보: " + evaluateHand(playerCards));
        System.out.println("컴퓨터의 족보: " + evaluateHand(computerCards));

        // 승자 결정
        int result = compareHands(evaluateHand(playerCards), evaluateHand(computerCards));
        if (result > 0) {
            System.out.println("플레이어 승리!");
        } else if (result < 0) {
            System.out.println("컴퓨터 승리!");
        } else {
            System.out.println("무승부!");
        }
    }
    private static int compareHands(String playerHand, String computerHand) {
        // 족보 우선 순위를 비교하여 승자를 결정
        // 여기서는 간단히 높은 족보일수록 우위라 가정

        // 족보 우선 순위를 숫자로 변환하여 비교 (족보 순서대로 1부터 시작)
        int playerPriority = getHandPriority(playerHand);
        int computerPriority = getHandPriority(computerHand);

        return Integer.compare(playerPriority, computerPriority);
    }
    private static int getHandPriority(String hand) {
        // 각 족보의 우선 순위를 반환
        switch (hand) {
            case "로열 플러시":
                return 10;
            case "백스트레이트 플러시":
                return 9;
            case "스트레이트 플러시":
                return 8;
            case "포커":
                return 7;
            case "풀 하우스":
                return 6;
            case "플러시":
                return 5;
            case "마운틴":
                return 4;
            case "백스트레이트":
                return 3;
            case "스트레이트":
                return 2;
            case "트리플":
                return 1;
            case "투 페어":
                return 0;
            case "원페어":
                return -1;
            default:
                return -2; // 하이카드 및 알 수 없는 경우
        }
    }

    private static String[] generateCards(String[] cardcase, String[] cardnumber, int count) {
        String[] cards = new String[count];
        for (int i = 0; i < count; i++) {
            int cardfront = (int) (Math.random() * cardcase.length);
            int cardback = (int) (Math.random() * cardnumber.length);
            cards[i] = cardcase[cardfront] + " " + cardnumber[cardback];
        }
        return cards;
    }

    private static void printCards(String[] cards) {
        for (String card : cards) {
            System.out.print(card + "\t");
        }
        System.out.println();
    }

    private static String evaluateHand(String[] cards) {
        Arrays.sort(cards);

        if (isRoyalFlush(cards)) {
            return "로열 플러시";
        } else if (isBackStraightFlush(cards)) {
            return "백스트레이트 플러시";
        } else if (isStraightFlush(cards)) {
            return "스트레이트 플러시";
        } else if (isFourOfAKind(cards)) {
            return "포커";
        } else if (isFullHouse(cards)) {
            return "풀 하우스";
        } else if (isFlush(cards)) {
            return "플러시";
        } else if (isMountain(cards)) {
            return "마운틴";
        } else if (isBackStraight(cards)) {
            return "백스트레이트";
        } else if (isStraight(cards)) {
            return "스트레이트";
        } else if (isTriple(cards)) {
            return "트리플";
        } else if (isTwoPair(cards)) {
            return "투 페어";
        } else if (isOnePair(cards)) {
            return "원페어";
        } else {
            return "하이카드";
        }
    }

    private static boolean isRoyalFlush(String[] cards) {
        // 1. 로열 플러시: 1, 10, J, Q, K로 구성된 같은 무늬의 5장
        return isStraightFlush(cards) && cards[0].endsWith("10") && cards[4].endsWith("A");
    }

    private static boolean isBackStraightFlush(String[] cards) {
        // 2. 백스트레이트 플러시: 1, 2, 3, 4, 5로 구성된 같은 무늬의 5장
        return isStraightFlush(cards) && cards[0].endsWith("2") && cards[4].endsWith("A");
    }

    private static boolean isStraightFlush(String[] cards) {
        // 3. 스트레이트 플러시: 같은 무늬이며 연속되는 5장
        return isFlush(cards) && isStraight(cards);
    }

    private static boolean isFourOfAKind(String[] cards) {
        // 4. 포커: 같은 숫자 4장
        return hasNOfAKind(cards, 4);
    }

    private static boolean isFullHouse(String[] cards) {
        // 5. 풀 하우스: 같은 숫자 3장과 같은 숫자 2장 구성
        return hasNOfAKind(cards, 3) && hasNOfAKind(cards, 2);
    }

    private static boolean isFlush(String[] cards) {
        // 6. 플러시: 같은 무늬의 5장
        return cards[0].startsWith(cards[4].substring(0, 1));
    }

    private static boolean isMountain(String[] cards) {
        // 7. 마운틴: 10, J, Q, K, 1로 구성된 5장
        return Arrays.equals(cards, new String[]{"10", "J", "Q", "K", "A"});
    }

    private static boolean isBackStraight(String[] cards) {
        // 8. 백스트레이트: 1, 2, 3, 4, 5로 구성된 5장
        return isStraight(cards) && cards[0].endsWith("2") && cards[4].endsWith("A");
    }

    private static boolean isStraight(String[] cards) {
        // 9. 스트레이트: 연속되는 5장
        for (int i = 1; i < cards.length; i++) {
            if (getCardValue(cards[i]) != getCardValue(cards[i - 1]) + 1) {
                return false;
            }
        }
        return true;
    }

    private static boolean isTriple(String[] cards) {
        // 10. 트리플: 같은 숫자 3장
        return hasNOfAKind(cards, 3);
    }

    private static boolean isTwoPair(String[] cards) {
        // 11. 투 페어: 같은 숫자 2장과 같은 숫자 2장 구성
        int pairCount = 0;
        for (int i = 0; i < cards.length - 1; i++) {
            if (cards[i].endsWith(cards[i + 1].substring(cards[i + 1].length() - 1))) {
                pairCount++;
                i++;
            }
        }
        return pairCount == 2;
    }

    private static boolean isOnePair(String[] cards) {
        // 12. 원페어: 같은 숫자 2장
        return hasNOfAKind(cards, 2);
    }

    private static boolean hasNOfAKind(String[] cards, int n) {
        int[] countArray = new int[15]; // 2부터 A까지 13개의 숫자 + 2 (14개)

        for (String card : cards) {
            int cardValue = getCardValue(card);
            countArray[cardValue]++;
        }

        for (int count : countArray) {
            if (count == n) {
                return true;
            }
        }
        return false;
    }

    private static int getCardValue(String card) {
        String cardNumber = card.substring(card.length() - 1);

        try {
            if ("A".equals(cardNumber)) {
                // "A"의 경우 14를 반환
                return 14;
            } else if ("K".equals(cardNumber)) {
                // "K"의 경우 13를 반환
                return 13;
            } else if ("Q".equals(cardNumber)) {
                // "Q"의 경우 12를 반환
                return 12;
            } else if ("J".equals(cardNumber)) {
                // "J"의 경우 11를 반환
                return 11;
            } else {
                // 그 외의 경우는 숫자로 변환
                return Integer.parseInt(cardNumber);
            }
        } catch (NumberFormatException e) {
            throw new IllegalArgumentException("Invalid card number");
        }
    }
}
