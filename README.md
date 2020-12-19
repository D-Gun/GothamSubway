# GothamSubway : ����ö ��� ���α׷�

# ����

- ����ö ���� ������ �����Ͽ� ��Ʈ�� ����ϴ� ����� C# .NET Framework�� EntityFramework �� DevExpress�� �̿��� �����Ͽ���.

# ���� �Ⱓ

- 2020�� 12�� 14�� ~ 2020�� 12�� 20��

# ���� �ο�

- IoT��� ����Ʈ���丮 SW���� ����������
- ����, �ȼ���, �̵��� �� 3��

# �ֿ� ���

## ��� ���

### �������ο�

-

### ��������

-

### ������

-

### ���� ��뷮

-

## �Է� ���

-

# ��� ���

## ���

- C# 8.0

## �����ӿ�ũ

- .Net FrameWork 4.8
- EntityFrameWork 6.2
- Winform

## �����ͺ��̽�

* MSSQL Server 2019

## Third Party

- DevExpress 20.2.3

## ��Ÿ ����ȯ��

- Windows 10
- Microsoft Visual Studio Community 2019 v16.8
- Microsoft SQL Server Management Studio v18.6

# �����ͺ��̽� ��Ű��

![��Ű��](./Document/��Ű��.png)

- ��� �׸��� �� 3 ����ȭ���� �Ϸ�ƴ�

# ���� ���̽� ���̾�׷�

![�������̽� ���̾�׷�](./Document/�������̽�_���̾�׷�.jpg)

# �÷ο���Ʈ

![������ ���̾�׷�](./Document/�÷ο���Ʈ.jpg)

# Ŭ���� ���̾�׷�

## DAO(Data Access Object)

![dao](./Document/Ŭ����_���̾�׷�/DAO.png)

# ������ ���̾�׷�

## ���� ���� ������

![������](./Document/������_���̾�׷�.png)

# Point of Interest

# DB ���̺��� �Ӽ� ���� �� ������Ʈ ������ EntityFramework�� �ݿ����� ���� ���� [#24](https://github.com/dlehd333/DKClinic/issues/24)

## ����
- ����ǥ ������ ���� �� ���� �߻�

## ����
- EntityFramework�� �ҷ��� �����ͺ��̽��� ����ǥ ���̺� PK�÷��� IDENTITY_INSERT �Ӽ��� OFF�� �Ǿ��־���

## ���
- ó������ DB�� �ִ� ����ǥ ���̺� PK�÷��� IDENTITY_INSERT �Ӽ��� ON���� �����ߴ�. ������ ���� ������ �߻��ߴ�.
- Ȯ�� ���, ó���� DB ��Ű�� ���� �� ���̺� PK�� IDENTITY_INSERT �Ӽ��� ON���� �ٲ��� �ʾҰ�, �� ���·� EntityFramework�� �ҷ���, EntityFramework�󿡴� IDENTITY_INSERT �Ӽ��� OFF�� ����Ǿ� �־���.
- �׷���, EntityFramework ���̾�׷����� ��Ŭ������ �����ϴ� '�����ͺ��̽����� �� ������Ʈ'�޴��� ����, ������Ʈ �����縦 �̿��� DB�� ������ ������Ʈ�Ͽ� ������ �ذ���
![update](https://user-images.githubusercontent.com/69996028/100321023-6b69d600-3005-11eb-8bb2-52bb1a5326c3.png)

---

# �ܷ�Ű�� ����� ���� ���̺��� ���� ���ÿ� �����ϴ� Ʈ����� �����߿� ������ �߻��ϴ� ���� [#24](https://github.com/dlehd333/DKClinic/issues/24)

## ����
- ���ο� Customer(ȯ��)�� ����ǥ�� �Է��ϸ�, ������ �߻�

## ����
- �ű� ȯ�ڰ� ����ǥ �Է��� �Ϸ�Ǹ� Customer(����), Questionnare(����ǥ), Response(����ǥ����) �� 3���� ���̺��� �����Ͱ� ���ԵǴµ�, �� �� �ű� ȯ�ڴ� ��� ������ CustomerID�� ����, Customer���̺����� Ű���� �ִ밪�� ������ ����ߴµ� �� ���� ���� IDENTITY �÷��� ���� ����Ǵ� ����� ���� �ʾ� ������ �߻��ߴ�
- ���� ���̺��� �����Ͱ� ���ÿ� ����Ǵ� Ʈ������� ���� �ʰ� IDENTITY �÷��� ���� �̸� ���ؼ� �����ϰų� �ٸ� ����� �ʿ��ߴ�.

## ���
- ó������ C#���� IDENTITY �÷��� ���� ���ϴ� ���� ã�� �־��µ�, �˻� �ϴ� ���� �ٸ� ����� �߰��ߴ�
- EF�� ID���� ã�� �Ҵ��ϴ� ���� �ƴ϶� ���̺� ��ü ��ü�� �Ҵ��ϴ� ����� �����ϸ�, EF�� ������ Entity �𵨿� �����Ǿ� �ִ� �ܷ�Ű�� ����� ���� ���� �̿��� ������ �� �ִٴ� ���� �˰� �Ǿ���.
- �׷��� Entity ���� ��ü�� ������ �� ���� ���̺� ��ü�� �������ָ�, �ѹ��� SaveChange�� �����ص� Insert�� ��ü�� ���� �ڵ����� IDŰ�� ����Ǿ� ������ �߻����� �ʰ� Ʈ�����ǵ� ������ �ʰ� �ȴ�.
- �׷��� ��ü�� ������ ��, ���� ���̺� ��ü�� �������ִ� �۾��� �����ߴ�.

```csharp
public Questionnare CreateQuestionnare { get; set; }

// before
CreateQuestionnare = new Questionnare();
// after
CreatedQuestionnare = new Questionnare { Customer = ConnectedCustomer };
```